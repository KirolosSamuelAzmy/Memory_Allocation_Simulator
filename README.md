# Memory_Allocation_Simulator
### It is an Windows based desktop application that is used to simulate different Operating System memory allocation algorithms.
### In Operating Systems, Segmentation is a memory management technique in which, the memory is divided into the variable size parts. Each part is known as segment which can be allocated to a process. The details about each segment are stored in a table called as segment table.

### It supports 2 different Scheduling Algorithms which are :
* First Fit .
* Best Fit.

#### The Application supports any kind of input like float input of Start of the hole or it size , or size of the segmentation of the process.

#### In order to take a look on the application , You should download a Zip file of the repo and then open the .exe file.


#### Here is a tutorial to open and use the application in a proper way : 

![71241597_3359494237407912_8890007713240372493_n](https://user-images.githubusercontent.com/66043730/85204430-bb38c880-b314-11ea-9713-37d9a873a382.png)
###### GUI 

![2](https://user-images.githubusercontent.com/66043730/85202673-58413480-b308-11ea-86bd-a23a12d732c2.png)

1. First you should enter the maximum memory size and then enter the holes properties (Size and Start in the memory) , If the total size of the holes is larger than the size of the memory , A message will shown up to the user to inform him to enter the new holes.

![3](https://user-images.githubusercontent.com/66043730/85202682-67c07d80-b308-11ea-8ced-3ff1d1f4b3ca.png)

2. After entering the proper values of the holes properties , a table of memeory in the left of the application will show up and also a segmentation table in the right.

3. You will have the choice to deallocate an initially allocated segment before entering any process. These screenshots below further illustrates the example.
![Deallocate](https://user-images.githubusercontent.com/66043730/85202686-7149e580-b308-11ea-8044-9f7ca8c345f8.png)
###### Deallocate Initially Allocated Segment Example.
![Deallocate2](https://user-images.githubusercontent.com/66043730/85202691-79a22080-b308-11ea-9c69-1a6418cded6e.png)
###### Deallocate Initially Allocated Segment Example Output.

4. Then, You will hava a choice to choose which Memory allocation algorithm to apply on the processes you will enter later.
5. If the incoming process can't be allocated , A message will show up to user to inform him to enter another proper process.

![First fit example](https://user-images.githubusercontent.com/66043730/85202602-c6392c00-b307-11ea-8d48-746336928ce6.PNG)
###### Adding Process by using First Fit Memory Allocation Algorithm.
![1st fit output](https://user-images.githubusercontent.com/66043730/85202600-c46f6880-b307-11ea-8bdc-c6a67bb836a5.PNG)
###### The output.




# Notes:
* You can start another scheduling without closing the current simulation
