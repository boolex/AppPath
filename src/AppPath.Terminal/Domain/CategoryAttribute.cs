namespace AppPath.Terminal.Domain
{
    public class CategoryAttribute
    {
        private readonly CategoryAttributeType type;
        public CategoryAttribute(CategoryAttributeType type)
        {
            this.type = type;
        }
    }
}
