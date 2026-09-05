namespace ToDoList2.Components.Pages
{
    public class ToDo
    {
        public string Description { get; set; }
        public bool DONE { get; set; }
        public override bool Equals(object? other)
        {
            return this.Description.Equals((other as ToDo).Description, StringComparison.OrdinalIgnoreCase);
        }
    }
}
