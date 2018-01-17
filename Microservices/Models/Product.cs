using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson.Serialization.Attributes;

namespace Microservices.Model
{
    public class Product
    {
        public Product()
        {
        }

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [MaxLength(10, ErrorMessage = "Name cannot be greater than 10"), MinLength(0)]
        public string Name
        {
            get;
            set;
        }
        public string CreatedByUserID
        {
            get;
            set;
        }

        [DataType(DataType.DateTime)]
        public DateTime? RowVersion
        {
            get;
            set;
        }
        [DataType(DataType.DateTime)]
        public DateTime? CreatedTime
        {
            get;
            set;
        }
        [DataType(DataType.DateTime)]
        public DateTime? ModifiedTime {
            get;
            set;
        }
        

    }
}
