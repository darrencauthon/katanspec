﻿using System;
using NSpec.Domain;
using System.Reflection;
using NSpec;
using System.Linq;

public class DebuggerShim
{
    public void debug()
    {
        var tagOrClassName = "kata";

        var invocation = new RunnerInvocation(Assembly.GetExecutingAssembly().Location, tagOrClassName);

        var contexts = invocation.Run();

        //assert that there aren't any failures
        contexts.Failures().Count().should_be(0);
    }
}
