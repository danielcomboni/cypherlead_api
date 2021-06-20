using Microsoft.Extensions.Logging;
using System;

namespace Cypherlead.Api.Core.Extensions
{
    public static class LoggingExtensions
    {
        public static void StartNew(this ILogger logger)
        {
            logger.LogInformation("");
            logger.LogInformation("================= STARTING NEW REQUEST =================");
        }

        /// <summary>
        /// Creating a new entity Log Message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="entityName"></param>
        public static void CreateNewEntityMessage(this ILogger logger, String entityName)
        {
            logger.LogInformation($"Creating new {entityName}");
        }

        /// <summary>
        /// Created a new entity Log Message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="entityName"></param>
        /// <param name="id"></param>
        public static void CreatedNewEntityMessage(this ILogger logger, String entityName, object id)
        {
            logger.LogInformation($"Created new {entityName} with ID: {id}");
        }

        public static void CreatingABatch(this ILogger logger, String entityName)
        {
            logger.LogInformation($"Creating a batch of: {entityName}"); 
        }

        /// <summary>
        /// Retrieving all entity records Log Message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="entityName"></param>
        public static void RetrievingAll(this ILogger logger, string entityName)
        {
            logger.LogInformation($"Retrieving all {entityName} collection");
        }

        /// <summary>
        /// Retrieving one entity Log Message based on ID
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="entityName"></param>
        /// <param name="id"></param>
        public static void RetrievingOneById(this ILogger logger, string entityName, object id)
        {
            logger.LogInformation("Retrieving {entityName} with ID: {ID}", entityName, id);
        }

        /// <summary>
        /// Invalid Request Log Message
        /// </summary>
        /// <param name="logger"></param>
        public static void InvalidRequest(this ILogger logger)
        {
            logger.LogInformation($"Invalid request.");
        }

        public static void InvalidData(this ILogger logger)
        {
            logger.LogInformation($"Invalid data");
        }

        /// <summary>
        /// Entity NOT FOUND Log Message based on ID
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="entityName"></param>
        /// <param name="id"></param>
        public static void NotFoundWithId(this ILogger logger, string entityName, object id)
        {
            logger.LogInformation($"{entityName} with ID: {id} NOT FOUND");
        }

        /// <summary>
        /// Entity FOUND Log Message base on ID
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="entityName"></param>
        /// <param name="id"></param>
        public static void FoundWithId(this ILogger logger, string entityName, object id)
        {
            logger.LogInformation($"{entityName} with ID: {id} FOUND");
        }

        /// <summary>
        /// Deleting entity Log Message based on ID
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="entityName"></param>
        /// <param name="id"></param>
        public static void DeletingAnEntityRecord(this ILogger logger, string entityName, object id)
        {
            logger.LogInformation("Deleting {entityName} with ID: {ID}", entityName, id);
        }

        /// <summary>
        /// Deleted entity record Log Message based on ID
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="entityName"></param>
        /// <param name="id"></param>
        public static void Deleted(this ILogger logger, string entityName, object id)
        {
            logger.LogInformation("{entityName} with ID: {ID} deleted", entityName, id);
        }

        /// <summary>
        /// Updating entity record Log Message based on ID
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="entityName"></param>
        /// <param name="id"></param>
        public static void Updating(this ILogger logger, string entityName, object id)
        {
            logger.LogInformation("Updating {entityName} with ID: {ID}", entityName, id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="entityName"></param>
        /// <param name="id"></param>
        public static void Updated(this ILogger logger, string entityName, object id)
        {
            logger.LogInformation("{entityName} with ID: {ID} MODIFIED", entityName, id);
        }

        public static void LogErrorExtension(this ILogger logger, Exception exception)
        {
            logger.LogError(exception, "global.error");
        }


        public static void CheckExistence(this ILogger logger, string entityName, object id)
        {
            logger.LogInformation("Checking existence of {entityName} with ID: {ID}", entityName, id);
        }

        public static void FoundToExist(this ILogger logger, string entityName, object id)
        {
            logger.LogInformation("Found {entityName} with ID: {ID}", entityName, id);
        }

        public static void FoundNotToExist(this ILogger logger, string entityName, object id)
        {
            logger.LogInformation("Not found {entityName} with ID: {ID}", entityName, id);
        }
    }
}
