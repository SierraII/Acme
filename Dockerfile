FROM mono
ADD ./src/App.Acme//App.Acme/bin/Release ./
CMD mono App.Acme.exe
