On Ubuntu:

1. install `gtk-sharp2` and `mono-complete` (v6.4+, I use the Mono PPA)
1. do `msbuild`
1. do `cd bin/Debug`
1. do `convert logo: logo.png` (generates a image to rotate, see [ImageMagick documentation](https://imagemagick.org/script/formats.php#builtin-images))
1. `mono repro.exe`
1. note that the logo is not animated as it should be.
