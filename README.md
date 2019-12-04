On Ubuntu:

1. install `gtk-sharp2` and `mono-complete` (v6.4+, I use the Mono PPA)
1. do `msbuild`
1. do `cd bin/Debug`
1. place a PNG image named `logo.png` in the current directory (if you have ImageMagick installed, you could use this command to generate one: `convert logo: logo.png`)
1. `mono repro.exe`
1. note that the logo is not animated as it should be.
