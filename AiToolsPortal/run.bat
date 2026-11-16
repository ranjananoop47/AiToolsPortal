@echo off
title AI Nexus Portal - ASP.NET MVC .NET Framework
echo ==========================================================
echo    AI Nexus Portal - ASP.NET MVC .NET Framework 4.8
echo ==========================================================
echo Starting IIS Express on http://localhost:5050 ...

set IIS_EXPRESS="C:\Program Files\IIS Express\iisexpress.exe"
if not exist %IIS_EXPRESS% set IIS_EXPRESS="C:\Program Files (x86)\IIS Express\iisexpress.exe"

if not exist %IIS_EXPRESS% (
    echo [ERROR] IIS Express not found!
    echo Please install IIS Express or open AiToolsPortal.sln in Visual Studio.
    pause
    exit /b 1
)

start "" http://localhost:5050
%IIS_EXPRESS% /path:"%~dp0." /port:5050
pause
