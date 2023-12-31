# The Mano Machine

The Mano Machine is a hypothetical RISC CPU designed by M. Morris Mano which appears in the 3rd edition of his book [Computer System Architecture](https://www.amazon.com/Computer-System-Architecture-Morris-Mano/dp/0131755633). Oddly enough, I couldn't find any reference to the 1st or 2nd editions of his book. You can read a bit more about the Mano Machine [here](https://wikipedia.org/wiki/Mano_machine).

I must make clear that I am not the designer or owner of the Mano Machine, all rights go to M. Morris Mano and the original publishers of his book.

A web app implementation of this project is available [here](https://github.com/husmus00/mano-web).

Note: The main source code is in a seperate [repository](https://github.com/husmus00/mano-src) to be used as a submodule.

# This Project
I took a course on computer architecture in early 2020 and the reference book for our course was the one mentioned above. I was interested in playing around with the Mano Machine but I could not find a modern easy-to-use emulator which would just work without hassle. 

So, I created this project both as a personal experiment and in the hopes that someone out there might benefit from it. If that does ever happen, feel free to contact me via <husmus7g@protonmail.com> to submit any bug reports or if you would just like to chat.

Note that I am *not* currently planning on adding any new (major) features to the project, only improving it in its current form.

**This project is incomplete. Some things still need to be done, if I ever get around to doing them:**
* The instructions and source code documentation need to be finalized.
* Ironing out all the bugs and cleaning the (somewhat messy) source code
* Input and output functionality doesn't yet exist. I'm still debating how I should implement it.
* Possibly adding more commands to the console for a little more ease-of-use, such as writing the binary output of the assembler to a file (although you can copy it from the console if you want)
* Improving the "debug" mode of program execution.

The entire project was created from scratch although I did take some inspiration from Github user [Amitayh](https://github.com/amitayh) and [their python implementation of the Mano Machine](https://github.com/amitayh/mano-machine-emulator) (I was not satisfied with this implementation as it functions as a library rather than a working program, since there was no interface to use it in any way as of the time of this project's creation).

# The Program
Instructions for using the program are in the **instructions.txt** file in the root of this project.

The program is designed with a console interface for ease of use, and since I envisioned this as a tool for use by students, I've added a little extra functionality in addition to the assembler and emulator, mainly a "debug" mode which steps through a program and shows the contents of the registers on each step.

I've programmed it in the C# .NET Core ~3.1 framework~ (Updated to .NET Core 8.0 LTS) using Visual Studio. I've uploaded the .sln project file so you can open it in VS if you like, or you can just use the .cs files located in the "**src**" directory.

A working executable for Windows is available on the [releases](https://github.com/husmus00/mano-machine-csharp/releases) page. If you want to use this program on MacOS or Linux, you can run it using the .NET Core framework which you can read about [here](https://docs.microsoft.com/en-us/dotnet/core/introduction) and download [here](https://dotnet.microsoft.com/download/dotnet-core) (Note that in this case you will only use the .cs files and not the rest of the VS project files). Note that I have not tested this on Linux or MacOS.

Example programs are located in the "**examples**" directory, which demonstrate how to write programs and to test how (and if) the machine works.

# License
This project is licensed under the GNU general public license (GPLv3). If you simply intend to use this program then you shouldn't be concerned, but if you want to modify and/or distribute this project make sure to read the terms of the license [here](https://www.gnu.org/licenses/gpl-3.0.en.html) or read the license file included in the root directory.
