using System;
using Grand.Core.Domain.Customers;
using MongoDB.Bson.Serialization.Attributes;

namespace Grand.Core.Domain.News
{
    /// <summary>
    /// Represents a news comment
    /// </summary>
    [BsonIgnoreExtraElements]
    public partial class NewsComment : SubBaseEntity
    {
        /// <summary>
        /// Gets or sets the comment title
        /// </summary>
        public string CommentTitle { get; set; }

        /// <summary>
        /// Gets or sets the comment text
        /// </summary>
        public string CommentText { get; set; }

        /// <summary>
        /// Gets or sets the news item identifier
        /// </summary>
        public string NewsItemId { get; set; }
        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

    }
}