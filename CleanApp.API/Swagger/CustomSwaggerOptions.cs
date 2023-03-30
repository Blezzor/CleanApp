using System;

namespace CleanApp.API.Swagger
{
    public static class CustomSwaggerOptions
    {
        public static string SchemaIdStrategy(Type currentClass)
        {
            string returnedValue = currentClass.Name;
            if (returnedValue.EndsWith("Dto"))
                returnedValue = returnedValue.Replace("Dto", string.Empty);
            return returnedValue;
        }
    }
}