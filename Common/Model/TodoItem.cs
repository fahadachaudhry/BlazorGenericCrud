using System.Diagnostics.CodeAnalysis;

namespace Common.Model
{
    public class TodoItem : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
