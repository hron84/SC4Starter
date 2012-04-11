SimCity 4 Starter
=================

This program is written for work around bug for processor affinity on multicore systems.

The program is starts SimCity 4 and sets CPU affinity and custom resolution (if set).

The program is not need and installation. Just download it from [Downloads section](https://github.com/hron84/SC4Starter/downloads) and put it anywhere on your disk.

Set custom resolution for wide screens
--------------------------------------

If you have a wide screen monitor, then you can specify your resolution to make game better.
To do this, open Regedit.exe, and navigate to HKLM\Software\Maxis\Sim City 4\ key (on 64 bit systems, this key is placed under HKLM\Software\Wow6432Node\Maxis\Sim City 4\), create a string value, name it to CustomResolution and specify your resoluton in WxHxB format (W - Width, H - Height, B - Colors bit). E.g. if you have a 1280x800 notebook LCD and you would like to use 32 bit color depth, you need specify 1280x800x32 in that string.
If you done with that, just close regedit and start SC4 via this loader.

This is an optional step, you do not need it if you are satisfied with current resolutions. 

WARNING: This registry value is used by this loader only, so do not expect customized resolution if you start SC4 on normal way.

Caveats
-------

This program is accesses registry and spawns a new process. If you are using an antivirus software with paranoid settings you need to give permission to these two actions for this program.

The starter itself will not appear on taskbar just in Process Manager.

License
-------

This program is licensed under CreativeCommons [BY-NC-SA 3.0 unported](http://creativecommons.org/licenses/by-nc-sa/3.0/) license.

The SimCity 4&trade; is a registered trademark of Electronic Arts Inc.

The icon of the app is created by Electronic Arts Inc. All rights reserved.
