To run server:
* Open solution in Visual Studio
* Press start
* Run tests from Test explorer

Call api with HTTP Verbs:
http://localhost:5001/api/messages

To post a message use this format:
{
	"subject": "Corona is over",
	"body": "Lorem Ipsum",
	"sender": "Christina",
	"receiver": "Jesper"
}

To patch with an operation, use this format:
{
	"operation": "MarkAsRead",
	"id": "36f24ec1-046b-4c4d-bdf1-3108896be749"
}

Database:
The database is a MongoDb that is hosted in Atlas/Azure (https://www.mongodb.com/). The database should be avaliable to connect to from any network.

There is a Collection named Message in a db named test.