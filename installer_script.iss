; ==============================================================================
; INNO SETUP INSTALLER SCRIPT
; Application: Sport Room Management System (SRMS)
; Institution: Sabaragamuwa University of Sri Lanka
; ==============================================================================

#define MyAppName "Sport Room Management System"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Sabaragamuwa University of Sri Lanka"
#define MyAppExeName "Project Sport Room.exe"

[Setup]
AppId={{C786DF91-0C71-464A-A45F-912217684C93}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
OutputDir=Output
OutputBaseFilename=SportRoom_Setup_v1.0
Compression=lzma2/ultra64
SolidCompression=yes
WizardStyle=modern
ArchitecturesInstallIn64BitMode=x64compatible
PrivilegesRequired=lowest

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"

[Files]
; All self-contained application binaries & runtimes
Source: "publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; Preserve existing user database on reinstall/upgrade so data is never lost
Source: "publish\sportroom.db"; DestDir: "{app}"; Flags: onlyifdoesntexist

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

