namespace AppPath.Terminal
{
    using AppPath.Terminal.Domain;
    using System.Collections.Generic;

    public class Model
    {
        private readonly List<Category> schema;

        public Model(List<Category> schema)
        {
            this.schema = schema;
        }
    }
}
