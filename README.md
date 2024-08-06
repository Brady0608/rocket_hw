![Version](https://img.shields.io/badge/version-v0.0.1-success)
###### tags: `Brogent` `ROS2` `SLAM` `Gmapping`
# autoride_slam

This package is designed to build a map using carious functions provided by the autoride series.

# Dependencies

Please review the remaining ROS2 dependencies listed in the [package.xml](package.xml) file.

# Usage

## 1. Check environment variable in the terminal

Please make sure that the environment variable "VEHICLE_NAME" is set up correctly. The default value for "VEHICLE_NAME" is "**autoride**".

You can set up "VEHICLE_NAME" by typing the following command in the terminal:

```
$ export VEHICLE_NAME=<vehicle_name>
```

For example, if you have a vehicle named "diff_robot," you would use this command:

```
$ export VEHICLE_NAME=diff_robot
```

## 2. check rviz2 configurations

In this package, open RViz2 using a configuration file corresponding to the environment variable "VEHICLE_NAME". 
In our case, the value of "VEHICLE_NAME" is "diff_robot", so the configuration file used to open RViz2 is stored in the "rviz/diff_robot" directory.

## 3. Start SLAM!

Now this package offers the following SLAM(Simultaneous Localization and Mapping) methods:
1. [Gmapping](#3.1-Launch-the-file-gmappinglaunchpy)
2. [Cartographer](#3.2-Launch-the-file-cartographerlaunchpy)

### 3.1 Gmapping

#### 3.1.1 Check the parameters

The default parameters for GMapping are saved in the file [param/gmapping.yaml](param/gmapping.yaml).

Please review the following critical parameters:

| Parameter    | Description                                                   | Default value |
|--------------|---------------------------------------------------------------|---------------|
| base_frame   | Indicates the name of the frame attached to the mobile base.  | base_link     |
| map_frame    | Indicates the name of the frame attached to the map.          | map           |
| scan_topic   | Which laser topic you use.                                    | /scan         |
| use_sim_time | Choose whether to use simulation time.                        | false         |

| :exclamation:  This is very important   |
|-----------------------------------------|

Parameters are stored in a folder named after the environment variable "VEHICLE_NAME". 
In our case, with "VEHICLE_NAME" set to "**diff_robot**", you can find the ["param/diff_robot/gmapping.yaml"](param/diff_robot/gmapping.yaml) file to review the parameters. 

If you want to know all parameters what they are doing, please refer to this link:
[gmapping - wiki](http://wiki.ros.org/gmapping)

#### 3.1.2 Check launch arguments

Here are serveral launch arguments you can use:

| Argument               | Description                            | Default value |
|------------------------|----------------------------------------|---------------|
| open_rviz              | Enable the Rviz2 tool.                 | true          |
| use_sim_time           | Choose whether to use simulation time. | false         |

#### 3.1.3 excute gmapping.launch.py script to build a map

After reviewing the parameters for GMapping and the launch arguments, 
you can now excute the relevant launch file to build a map using the GMapping algorithm.

Please enter the following command to excute the script.

```bash=
$ ros2 launch autoride_slam gmapping.launch.py open_rviz:=true 
```
![start gmapping](https://i.imgur.com/oY72yJv.png)

Great! Now you can navigate the robot to build a map of the environment.

### 3.2 Cartographer

#### 3.2.1 Check the parameters

The default parameters for Cartographer are saved in the file ["param/cartographer.lua"](param/cartographer.lua).

Please review the following critical parameters:

| Parameter      | Description                                                   | Default value |
|----------------|---------------------------------------------------------------|---------------|
| tracking_frame | Indicates the name of the frame attached to the mobile base.  | base_link     |
| map_frame      | Indicates the name of the frame attached to the map.          | map           |
| odom_frame     | Indicates the name of the frame attached to the odometry.     | odom          |

| :exclamation:  This is very important   |
|-----------------------------------------|

Parameters are stored in a folder named after the environment variable "VEHICLE_NAME". 
In our case, with "VEHICLE_NAME" set to "**diff_robot**", you can find the ["param/diff_robot/cartographer.lua"](param/diff_robot/cartographer.lua) file to review the parameters. 

If you want to know all parameters what they are doing, please refer to this link:
[Cartographer ROS Integration](https://google-cartographer-ros.readthedocs.io/en/latest/)


#### 3.2.2 Check launch arguments

Here are serveral launch arguments you can use:

| Argument               | Description                            | Default value |
|------------------------|----------------------------------------|---------------|
| laser_scan_topic       | Laser scan topic to subscribe          | /<VEHICLE_NAME>/laser/scan |
| open_rviz              | Enable the Rviz2 tool.                 | true          |
| use_robot_localization | Enable ekf filtered node               | false         |
| use_sim_time           | Choose whether to use simulation time. | false         |


#### 3.2.3 excute cartographer.launch.py script to build a map

After reviewing the parameters for Cartographer and the launch arguments, 
you can now excute the relevant launch file to build a map using the Cartographer algorithm.

Please enter the following command to excute the script.

```bash=
$ ros2 launch autoride_slam cartographer.launch.py open_rviz:=true 
```
![start cartographer](image/cartographer.png)

Great! Now you can navigate the robot to build a map of the environment.

## 4. Save static map

### 4.1 Check the parameters and launch arguments

Once you've built the static map, the next step is to save it.
You can use a launch script for this purpose.
Here are several launch arguments you can use:

| Argument               | Description                      | Default value  |
|------------------------|----------------------------------|----------------|
| map_name               | Map name you want to save        | <VEHICLE_NAME>_map_<YY>_<mm>_<dd>_<HH>_<MM>" |
| map_saver_param        | Parameters for node "map_saver" within the "param" folder. | map_saver.yaml |

| :exclamation:  This is very important   |
|-----------------------------------------|

Regardless of the robot you use, the parameters for the node "map_saver" are consistent.
Therefore, "param/map_saver.yaml" is used as the default configuration file.

```
|-- autoride_slam
|   |-- param
|   |   |-- diff_robot
|   |   |   |...
|   |   |-- cartographer.lua
|   |   |-- gmapping.yaml
|   |   `-- map_saver.yaml -> default parameters for using the node "map_saver"
```

### 4.2 excute save_map.launch.py script to save the map

After reviewing the parameters for then node "map_saver" and the launch arguments, 
you can now excute the relevant launch file to save the map.

Please enter the following command to excute the script.
```bash=
$ ros2 launch autoride_slam save_map.launch.py
```
If saved successfully, you will see the following files within the folder "map".
![save static map](https://i.imgur.com/lyX4w09.png)


If you want to specify a custom map name, you can add the "map_name" option after the command.
Here is an example:
```bash=
$ ros2 launch autoride_slam save_map.launch.py map_name:=test
```
Then you will see the following files within the folder "map". 
![save static map with custom name](https://i.imgur.com/pzyCnA9.png)

## 6. Remember to close all program

After saving static map, remember to use keyboard [Ctrl] + [C] on each running terminal to close related program.

# Next Step

You can follow this package [autoride_navigation](../autoride_navigation2/README.md) to navigate your robot with ROS2.



# Developer log 

- Developer: Joe Lin(joe_lin@brogent.com)

| Date       | State         |
|------------|---------------|
| 2024/04/17 | Update README | 