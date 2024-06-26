﻿using System.Diagnostics.CodeAnalysis;

namespace Ncea.Mapper.Utils;

[ExcludeFromCodeCoverage]
public static class CustomLogger
{
    public static void LogErrorMessage(ILogger logger, string errorMessage, Exception? exception)
    {
#pragma warning disable CA2254 // Template should be a static expression
        logger.LogError(exception, errorMessage);
#pragma warning restore CA2254 // Template should be a static expression
    }
    public static void LogWarningMessage(ILogger logger, string errorMessage, Exception? exception)
    {
#pragma warning disable CA2254 // Template should be a static expression
        logger.LogWarning(exception, errorMessage);
#pragma warning restore CA2254 // Template should be a static expression
    }
}
