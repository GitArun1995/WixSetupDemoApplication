@echo off

"C:\Program Files (x86)\WiX Toolset v3.11\bin\heat.exe" dir "D:\source\repos\WixSetupProject\SampleProject\ShellProject\bin\Release" -o "D:\source\repos\WixSetupProject\SampleProject\DemoProject\ProductComponents.wxs" -dr INSTALLFOLDER -cg ProductComponents -srd -scom -sreg -gg -t "D:\source\repos\WixSetupProject\ExcludePdb.xslt"

pause