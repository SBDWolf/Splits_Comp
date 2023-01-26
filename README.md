# Splits_Comp

A User Interface to generate Livesplit comparisions.

All the math (the great majority of the comp.py script) was done by ShadyGamerX. I have merely made this hacky User Interface that calls that script.

As for how all of this works:

There are three main functions to this program:
- The generation of a Balanced comparison;
- The generation of a Reset comparison;
- The calculation of a chance to beat a target time.

It is always necessary to provide the path to your splits file, and the target time. You can leave the "Use PB checkbox" on to use the PB listed in the splits file.

The recency weight value refers to geometric decay. It is used to determine how much more influential recent splits are in the calculations.

You can also tick the Linear decay checkbox to use linear decay for recency weighing, instead.

The Chunkify option can speed up the process at the cost of accuracy. The higher the value, the faster and less accurate it should be.

Reset iterations is used in the Reset calculation.

For "Sim Chance", you have to provide a starting point from which to calculate a chance of beating the target time.

Sim Chance split is the split index number (non-0-index).

Sim Chance time is the time achieved at that split index.

So for example, if you wanted to calculate the odds of beating the target time after getting a 01:20:34 at split 15, Sim Chance split would be 15, and Sim Chance time would be 01:20:34.

---
If you want to build from source, you will have to manually place the comp.py and execute.bat files in the same directory where the final .exe would be.
