<p align="center">
	<a href="https://github.com/gourav263587/IOT1026-Assignment-3/actions/workflows/ci.yml">
    <img src="https://github.com/gourav263587/IOT1026-Assignment-3/actions/workflows/ci.yml/badge.svg"/>
    </a>
	<a href="https://github.com/gourav263587/IOT1026-Assignment-3/actions/workflows/formatting.yml">
    <img src="https://github.com/gourav263587/IOT1026-Assignment-3/actions/workflows/formatting.yml/badge.svg"/>
	<br/>
    <a href="https://codecov.io/gh/gourav263587/IOT1026-Assignment-3" > 
    <img src="https://codecov.io/gh/gourav263587/IOT1026-Assignment-3/branch/main/graph/badge.svg?token=JS0857X5JD"/> 
	<img title="MIT License" alt="license" src="https://img.shields.io/badge/license-MIT-informational?style=flat-square">	
    </a>
</p>

# IOT1026-Assignment-3
        
This project is a simple inventory management system. It consists of two main classes: InventoryItem and Pack.

The InventoryItem class represents an item in the inventory. It has properties like Name, Weight, and Volume. The class allows creating inventory items with specific attributes.

The Pack class represents a backpack that can store multiple inventory items. It has properties like maxCount, maxVolume, and maxWeight to define the constraints of the pack. The class provides methods to add items to the pack and calculates the total weight and volume of the items stored.

The PackTester class is a utility class that allows users to interactively test the functionality of the Pack class. It presents a menu of available items and prompts the user to add items to the pack. It handles input validation and displays the contents of the pack after each addition.

The Program class is the entry point of the application. It creates an instance of the Pack class and calls the AddEquipment method of the PackTester class to start the interactive testing.

Overall, this project demonstrates a basic inventory management system with the ability to add items to a pack and check the constraints of the pack.
        
        
        
[Assignment Instructions](docs/instructions.md)  
[How to start coding](docs/how-to-use.md)  
[How to update status badges](docs/how-to-update-badges.md)
