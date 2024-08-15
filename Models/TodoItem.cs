public class TodoItem
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty; 
    public bool Completed { get; set; }

    public TodoItem() { }

    public TodoItem(string text)
    {
        Text = text;
        Completed = false;
    }
}
