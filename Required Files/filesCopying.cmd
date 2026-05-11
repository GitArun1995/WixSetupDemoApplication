@echo off

for /r "C:\Users\arunkumar.tn\Desktop\Raw files" %%f in (*.exe *.dll) do (
    copy "%%f" "C:\Users\arunkumar.tn\Desktop\Encrypted files"
)

pause