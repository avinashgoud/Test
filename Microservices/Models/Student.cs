using System;
using MongoDB.Bson.Serialization.Attributes;
namespace Microservices.Model
{
    public class Student
    {
        public Student()
        {
        }

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name
        {
            get;
            set;
        }
        public string RollNumber
        {
            get;
            set;
        }
        public long DateEpoch
        {
            get;
            set;
        }

    }
}
