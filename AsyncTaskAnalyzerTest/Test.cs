public class Test
{
    public void ClassicMethod()
    {
        var sa = new SimpleAsync();
        
        // not awaited Tasks are correctly marked when returned value is unassigned
        sa.JustTask();
        sa.TaskWithValue();
        SimpleStaticAsync.JustTask();
        SimpleStaticAsync.TaskWithValue();
        
        // Now the same thing with assigning to variables - these are not marked - yet they are never awaited
        // IMO that introduces bugs - at least in our code after changes from sync to async/await where we use var
        var a = sa.JustTask();
        var b = sa.TaskWithValue();
        var c = SimpleStaticAsync.JustTask();
        var d = SimpleStaticAsync.TaskWithValue();
        
        Console.WriteLine(a.ToString());
        Console.WriteLine(b.ToString());
        Console.WriteLine(c.ToString());
        Console.WriteLine(d.ToString());
        
        // IMO these shouldn't be marked, since I want fire & forget them  
        _ = sa.JustTask();
        _ = sa.TaskWithValue();
        _ = SimpleStaticAsync.JustTask();
        _ = SimpleStaticAsync.TaskWithValue();
    }

    public async Task AsyncMethod()
    {
        var sa = new SimpleAsync();
        await sa.JustTask();
        // not awaited Tasks are correctly marked when returned value is unassigned
        sa.JustTask();
        sa.TaskWithValue();
        SimpleStaticAsync.JustTask();
        SimpleStaticAsync.TaskWithValue();
        
        // Now the same thing with assigning to variables - these are not marked - yet they are never awaited
        // IMO that introduces bugs - at least in our code after changes from sync to async/await where we use var
        var a = sa.JustTask();
        var b = sa.TaskWithValue();
        var c = SimpleStaticAsync.JustTask();
        var d = SimpleStaticAsync.TaskWithValue();
        
        Console.WriteLine(a.ToString());
        Console.WriteLine(b.ToString());
        Console.WriteLine(c.ToString());
        Console.WriteLine(d.ToString());
        
        // IMO these shouldn't be marked, since I want fire & forget them  
        _ = sa.JustTask();
        _ = sa.TaskWithValue();
        _ = SimpleStaticAsync.JustTask();
        _ = SimpleStaticAsync.TaskWithValue();
    }
}