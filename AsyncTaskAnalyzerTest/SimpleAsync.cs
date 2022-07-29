public class SimpleAsync
{
    public async Task JustTask()
    {
        await Task.Delay(100);
    }
    
    public async Task<string> TaskWithValue()
    {
        await Task.Delay(100);
        return "TaDa!";
    }
}

public static class SimpleStaticAsync
{
    public static async Task JustTask()
    {
        await Task.Delay(100);
    }
    
    public static async Task<string> TaskWithValue()
    {
        await Task.Delay(100);
        return "TaDa!";
    }
}