# CSharp-VideoGameItemSystem

This program demonstrates how to use OOP techniques to create a text-based item/inventory system that could be used within a video game.

## How the items are organised
- Base class Item.cs (This has attributes that all items will need: Value and Weight).
- Weapon.cs and Armour.cs inherit from Item.cs (and add specific attributes such as 'Attack Power' for weapons).
- Individial weapon types inherit from Weapon.cs
- Individial armour types inherit from Armour.cs

## How the inventory system works
- Player.cs has an Inventory object.
- Inventory.cs contains an array of a certain length (specified in the constructor, this is the size of the inventory).
- Only objects that inherit from Item can be placed in the array.
- If a 'slot' is null, the slot is shown as 'None' which means no item exists in that slot.
- Items can be 'Picked up' and assigned to the first available (empty) 'slot'.
- If a 'slot' holds an Item, the item can be dropped or it can swap to another 'slot'.

## Image of test data
This is to clearly show what is happening at every step.
![image](https://user-images.githubusercontent.com/20408968/126556335-adb28e8f-65b6-4271-974a-9ea1972ff326.png)

## Some concepts that this project demonstrates
- Inheritance 
- Encapsulation
- Output to console
- Input from console
- Arrays
- Objects
- Regex
- Null Conditional Operator
- Conditional Operator
- Abstract classes and functions
- Namespaces
- Input validation
- Use of source control
