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



Trade-offs:
Following might be implemented later to make this usable in production:

Dependency injection
Exception handling
Security
User registration
Verify users before sending
Performance
Handling different environments like production, development, test

Eventually introduce a class type that is "Use case", which holds rules that are not implemented in the domain entities themselves.



Tests:
Check whether the correct exception it thrown (not just any exception).
Integration/Acceptance tests testing the API over http