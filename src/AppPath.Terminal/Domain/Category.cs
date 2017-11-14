namespace AppPath.Terminal.Domain
{
    using System.Collections.Generic;

    public class Category
    {
        private readonly CategoryType type;
        private readonly IList<CategoryAttribute> attributes;
        private readonly IList<CategoryDependency> dependencies;

        public Category(
            CategoryType type,
            IList<CategoryAttribute> attributes,
            IList<CategoryDependency> dependencies)
        {
            this.type = type;
            this.attributes = attributes;
            this.dependencies = dependencies;
        }


    }
}
