# Debug-Detect
Basic debugger detection in C# (Process Monitor, Anti-Debugger)

## Instructions
- Clone & Build the DLL
- Add Debug-Detect.dll as a reference to your project
- Go to the main function (before the GUI appears) and add the following code in it:
```cs
string urlForHashCheck = "https://pastebin.com/raw/eFKXR4Jq"; // Upload the MD5 hash of your finished file to pastebin (an alternative site may also be used)
bool AntiDump = true; // Set this to true if you want to prevent your assembly from being dumped from the memory
bool AntiDebug = true; // Activates the process monitor and scans for debugger tools
bool AntiEmulation = true; // Blocks emulation, virtual machines & sandboxie
List<string> AntiNetBlacklist = new List<string>() { "pastebin.com", "mywebsite.tld", "someIpOfYourServer" }; // Add your website(s) to be blocked from host file editing

debug_detect.Main.Start(urlForHashCheck, AntiDump, AntiDebug, AntiEmulation, AntiNetBlacklist); // Run Debug-Detect with the settings provided above
```
