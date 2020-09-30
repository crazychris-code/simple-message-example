using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MessagingService.Controllers.ServiceModel;
using MessagingService.Controllers.Translators;
using MessagingService.Repository;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessagingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [EnableCors()]
    public class MessagesController : ControllerBase
    {
        private MessageRepository _messageRepository;

        public MessagesController()
        {
            _messageRepository = new MessageRepository();
        }

        // GET: api/<MessagesController>
        [HttpGet]
        public List<Message> Get()
        {
            return MessageTranslator.ToServiceModel(_messageRepository.GetAll());
        }

        // GET api/<MessagesController>/5
        [HttpGet("{id}")]
        public Message Get(string id)
        {
            return MessageTranslator.ToServiceModel(_messageRepository.Get(Guid.Parse(id)));
        }

        // POST api/<MessagesController>
        [HttpPost]
        public void Post([FromBody] Message message)
        {
            _messageRepository.Add(MessageTranslator.ToDomain(message));
        }

        // PUT api/<MessagesController>
        [HttpPut]
        public void Put([FromBody] Message message)
        {
            _messageRepository.Save(MessageTranslator.ToDomain(message));
        }

        // PATCH api/<MessagesController>
        [HttpPatch]
        public void Patch([FromBody] PatchRequest patchRequest)
        {
            var id = Guid.Parse(patchRequest.Id);
            var message = _messageRepository.Get(id);
            if (message == null) return;

            switch (patchRequest.Operation)
            {
                case PatchRequest.MarkAsRead:
                    message.MarkAsRead();
                    break;

                default:
                    return;
            }

            _messageRepository.Save(message);
        }

        // DELETE api/<MessagesController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _messageRepository.Delete(Guid.Parse(id));
        }
    }
}
