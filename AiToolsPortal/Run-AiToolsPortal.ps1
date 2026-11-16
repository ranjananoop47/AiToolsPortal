# Launcher for AI Tools Intelligence Portal
$projectDir = "$PSScriptRoot"
$port = 5050
$iisExpressPath = "C:\Program Files\IIS Express\iisexpress.exe"

if (-not (Test-Path $iisExpressPath)) {
    $iisExpressPath = "C:\Program Files (x86)\IIS Express\iisexpress.exe"
}

if (-not (Test-Path $iisExpressPath)) {
    Write-Error "IIS Express executable was not found. Please install IIS Express or open AiToolsPortal.sln in Visual Studio."
    exit 1
}

Write-Host "==========================================================" -ForegroundColor Cyan
Write-Host "   AI Nexus Portal - ASP.NET MVC .NET Framework 4.8       " -ForegroundColor Yellow
Write-Host "==========================================================" -ForegroundColor Cyan
Write-Host "Starting IIS Express on http://localhost:$port..." -ForegroundColor Green

# Start IIS Express process
$proc = Start-Process -FilePath $iisExpressPath -ArgumentList "/path:`"$projectDir`"", "/port:$port" -PassThru

# Wait 2 seconds and open default browser
Start-Sleep -Seconds 2
Start-Process "http://localhost:$port"

Write-Host "Portal running! Press CTRL+C or close this window to stop." -ForegroundColor Gray
$proc.WaitForExit()
