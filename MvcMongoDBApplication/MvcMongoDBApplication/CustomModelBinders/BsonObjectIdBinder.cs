namespace MvcMongoDBApplication.CustomModelBinders
{
    using System.Web.Mvc;
    using MongoDB.Bson;

    public class BsonObjectIdBinder : IModelBinder
    {
        public object BindModel( ControllerContext controllerContext, ModelBindingContext modelBindingContext)
        {
            //// Retrieve a value object using modelBindingContext.ModelName as the key
            var valueProviderResult = modelBindingContext.ValueProvider.GetValue(modelBindingContext.ModelName);
            //// Now, create and return a new instance of MongoDB.Bson.ObjectId with the raw string retrieved from the model's property
            return new ObjectId(valueProviderResult.AttemptedValue);
        }
    }
}