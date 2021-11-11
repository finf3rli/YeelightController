# YeelightController
C# UI xiaomi bulb controller

## What does it do

Manages color and power state of a xiaomi bulb.
Given the ip address, you can change color from this program.
It should appear a bulb icon on the traybar.
One click will show a color spectrum; by clicking it, it will
change color of the bulb. The button beneath turns on/off the bulb.
Right click gives you the possibility to close the program.

You can set it to open on boot for windows by adding a shortcut in the `shell:startup` folder.

## Problems

~~If the lamp goes offline, you are most likely required to reopen the program, because it hasn't
been implemented yet a connection verifier handle.~~

Each time you open from notify icon it tries to connect. Still no Exception handler nor connection messages
have been implemented(yet).

Unfortunately i'm not able to set white colors.
