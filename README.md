# Final Project Proposal: Name TBD

The main loop of our game is you are a conductor for some space train and your goal is to keep the train running via shovleling space coal and other train maintance.

Calvin Kim, Quintan Gerhardstein

## Project Description

Become the ultimate space conductor in a thrilling game where you’re in charge of the Intergalactic Train Committee! Operate within a limited area, managing critical tasks aboard the star-bound freight train. Your mission? Keep the engines fueled and secure the precious cargo as you race through the cosmos. But beware—hostile alien lifeforms have their own ideas and will stop at nothing to disrupt your journey! Protect the cargo, fend off intruders, and ensure the train reaches its destination. Can you survive the journey, or will you face the wrath of the Intergalactic Train Committee?

## Feature Breakdown

1. **Real time grabbing of objects**: Grabbing the train coal with the VR controllers to move it into the engine furnace. 
   - **Estimated Challenge - 1:** The grabbing intertactions need to feel smooth and not cumborsum to keep holding onto an object.
2. **Fuel progress check**: As the train progresses more and more fuel is used to keep the train moving, this will be displayed on a screen in the main cabin to show the progress.
   - **Estimated Challenge - 2:** The main difficulty is from reading a value in from a script and putting it on a text mesh pro.
3. **Alien Bandits try to fly in and steal the freight**: The aliens will b-line to the freight and you as the conductor have to shoot them down to stop them.
   - **Estimated Challenge - 3:** The tracking of enemies on a specififc cago crate and being able to pick it up and take it away.
4. **Tank Heat**: Manage the tank temprature to keep the train for the engine by turing a valve. The pressure/heat warning will also be shown in the main cabin display. 
   - **Estimated Challenge - 2:** Same as the fuel progress display, writing to the text mesh pro in real  time will be the main challenge.
5. (OPTIONAL) **Train repairs**: As the train is ransacked, parts will have to be boarded up and held togehter to keep the train from falling apart.
   - **Estimated Challenge - 5:** Having real time damage and repairs will greatly increase the difficulty and processing requirements of the quest 3. That is why this goal is optional as it will be implemented if there is remaining time and resources to do so. 
6. **Multiple stops** The train has two stops before the final destinations, at theses stops you can purchace upgrades to improve the train.
   - **Estimated Challenge - 4:** Implementing a new scene that has a menu of upgrades for the main gameplay that can be interacted with in VR. The upgrades also being able to then affect gameplay for multiple scenes is an important part of balancing as well. 

## Milestones

1. **By 11/19** - Train working enviorment set up. Base interactions implemented.
2. **By 11/26** - Test all base functionalities to ensure they are working before going into visual additions.
3. **By 12/5** - Refine and add approate visuals and audio sources, most bugs fixed.

## Inspirations 
1. Job Simulator - https://www.meta.com/experiences/job-simulator/3235570703151406/
We took inspiration about this as this game is heavily focus on doing task for a certain job and we wanted it took have a similar feel in the gameplay loop.
2. Choo-Choo Charles - https://store.steampowered.com/app/1766740/ChooChoo_Charles/
We took inspiration from its train upgrades and the weapon system. We liked the idea of going around and being able to upgrade your train and going to certain stations in order to make those upgrade and visual changes.

## Concept Sketches
[Train Layout and enemy concept](https://github.com/caki9282/VRArcade/blob/main/Images/Train%20Layout.png)
[Upgrade shop concept](https://github.com/caki9282/VRArcade/blob/main/Images/Shop.png)
