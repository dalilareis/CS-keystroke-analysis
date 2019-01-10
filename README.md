# Keystroke and Emotion Analysis

This project analyses keystroke input and associated emotions. Keystrokes were captured using the project **HookLib**. 
The generated .txt file is then used to extract relevant features. Various statistics are then calculated from these features. 
The text's associated emotions were based on the **EmoLex** and it is possible to analyse text in English and Portuguese. 

The system is able to relate emotions to writing patterns.

## Usage

The text used in this project is defined on the `sample.txt` file. If you want to use a different text or a different user input, you need to run the HookLib project to capture the keystrokes. The generated file should then be placed in the `ConsoleApp1\bin\Debug` folder, under the name `log.txt`. Now you can run the main program, `TP1_2`, to analyse the new file.
