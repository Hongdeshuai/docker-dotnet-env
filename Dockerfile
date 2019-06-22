# escape=`
FROM mcr.microsoft.com/windows/servercore:ltsc2016

ENV COMPLUS_NGenProtectedProcess_FeatureEnabled 0
RUN \Windows\Microsoft.NET\Framework64\v4.0.30319\ngen update & `
    \Windows\Microsoft.NET\Framework\v4.0.30319\ngen update

WORKDIR "C:\\tester\\"

COPY settings.reg .
COPY setup.msi .

RUN powershell Invoke-Command -ScriptBlock {regedit /i /s settings.reg}
SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop'; $ProgressPreference = 'SilentlyContinue';"]

RUN Start-Process 'setup.msi' '/qn' -PassThru