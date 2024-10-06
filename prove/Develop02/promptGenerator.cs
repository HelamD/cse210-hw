public class PromptGenerator
{
    private List<string> _prompt = new List<string>
    {
        "What made you smile today?",
        "What did you learn today?",
        "What was the best part of your day?",
        "How did you help someone today?",
        "What are you grateful for?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }
}