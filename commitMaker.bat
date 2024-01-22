@echo off
git log --since="1 day ago" --pretty=format:"%%h - %%s" > commits.txt
echo Commit logs from the past two days have been saved to commits.txt
pause
