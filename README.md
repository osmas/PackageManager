# PackageManager
find the dependencies based on the data supplied by a package dependencies file

This is a windows based console application developed in Visual Studio 2013. It will run at 
the command prompt (CMD.exe). It will be run as : DependencyApp <datafile> <package1> <package2> .... <packageN)

Where args[0] will be the package text (e.g package.txt) file that contains the dependency information such as :
gui -> awtui swingui
swingui -> runner extensions
textui -> runner framework
awtui -> runner
runner -> framework
extensions -> framework
 
 It is assumed this file will be placed in the same location/folder as the executable program file (DependencyApp.exe)
 
 The program will then take a any number of package names as arguments after the datafile.
 
 e.g the command )           :/>DependencyApp packages.txt swingui awtui unknown
 
 Should output: )                swingui -> extensions framework runner
                                 awtui -> framework runner
                                 unknown -> 
