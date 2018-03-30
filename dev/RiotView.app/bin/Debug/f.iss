; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{AEDB0CCF-F7A4-4AFF-9E26-8741FFADA796}
AppName=RitoView
AppVersion=1.0
;AppVerName=RitoView 1.0
AppPublisher=Clermont Informatique Inc.
AppPublisherURL=http://euw.leagueoflegends.com/fr
AppSupportURL=http://euw.leagueoflegends.com/fr
AppUpdatesURL=http://euw.leagueoflegends.com/fr
DefaultDirName={pf}\RitoView
DisableProgramGroupPage=yes
OutputDir=C:\Users\julien\Desktop
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\RiotView.app.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\Champion.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\Champion.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\DBCon.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\fichier.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\RiotView.app.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\RiotView.app.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\RiotView.app.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\RiotView.app.vshost.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\RiotView.app.vshost.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\RiotView.app.vshost.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\Service.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\Service.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\Utilisateurs.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\julien\Desktop\Nouveau dossier (2)\ritoview\dev\RiotView.app\bin\Debug\Utilisateurs.pdb"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\RitoView"; Filename: "{app}\RiotView.app.exe"
Name: "{commondesktop}\RitoView"; Filename: "{app}\RiotView.app.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\RiotView.app.exe"; Description: "{cm:LaunchProgram,RitoView}"; Flags: nowait postinstall skipifsilent

