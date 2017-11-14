namespace AppPath.Terminal
{
    using System;
    using System.Collections.Generic;

    using AppPath.Terminal.Domain;

    class Program
    {

        static void Main(string[] args)
        {

            var model = new Model(schema: new List<Category>
            {
                new Category(
                    CategoryType.Team, 
                    new List<CategoryAttribute>{
                        new CategoryAttribute(CategoryAttributeType.Sequential),
                        new CategoryAttribute(CategoryAttributeType.MinCount)
                    },
                    new List<CategoryDependency>{
                        new CategoryDependency(
                            CategoryDependencyType.IntersectionIntroducesNewValue, 
                            CategoryType.Stop,
                            new Tuple<Relation,Relation>(Relation.Many, Relation.Many))
                    }
                ),
                new Category(
                    CategoryType.Stop, 
                    new List<CategoryAttribute>{
                    },
                    new List<CategoryDependency>{
                    }
                )                
            });
        }
    }
}
