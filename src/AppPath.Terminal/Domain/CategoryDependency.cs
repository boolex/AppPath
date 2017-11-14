using System;
namespace AppPath.Terminal.Domain
{
    public class CategoryDependency
    {
        private readonly CategoryType target;
        private readonly CategoryDependencyType type;
        private readonly Tuple<Relation, Relation> relation;
        public CategoryDependency(CategoryDependencyType type, CategoryType target, Tuple<Relation, Relation> relation)
        {
            this.type = type;
            this.target = target;
            this.relation = relation;
        }
    }
}
