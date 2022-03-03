# Project 4: Virtual Reality - Group E

<details>
<summary>Table of content</summary>

- [Project 4: Virtual Reality - Group E](#project-4-virtual-reality---group-e)
- [Overview](#overview)
  - [1. Stakeholders](#1-stakeholders)
  - [2. Project target](#2-project-target)
  - [3. Project and scope](#3-project-and-scope)
  - [4. Risks and assumptions](#4-risks-and-assumptions)
  - [5. Requirements specs](#5-requirements-specs)
  - [6. Solution overview](#6-solution-overview)
  - [7. Use cases](#7-use-cases)
  - [8. User flow](#8-user-flow)
    - [Student](#student)
    - [Staff](#staff)
    - [Professor](#professor)

</details>
<br>

Functional Specification **February 2022**

Team: _Paul MARIS, Clément CATON, Laurent BOUQUIN, Florent HUREAUX, Léo CHARTIER, Pierre GORIN_

<br>

# Overview

Our project is based on Virtual Reality (VR)[^0]. We have to ensure the provided model of the Algosup[^1] premises at the B3[^2] will correspond to the school needs and later use it to simulate a typical day.

<br>

## 1. Stakeholders

| Person/Organization  | Role            |
| -------------------- | --------------- |
| ALGOSUP              | Customers       |
| Sébastien GOISBEAULT | Tech consultant |
| Paul      MARIS      | Project manager |
| Clément   CATON      | Tech lead       |
| Laurent   BOUQUIN    | Team member     |
| Florent   HUREAUX    | Team member     |
| Léo       CHARTIER   | Team member     |
| Pierre    GORIN      | Team member     |

<br>

## 2. Project target

The goal of this project is to furnish the building with furniture that would be used later in real life.

Later we will have to give life to the 3D model of the school in VR. This means we need to create interactivity with the components around the school in order to fully experience a day in the life of a school member.
This means simulating things such as doors, classes, general daily life and many other things that we have to imagine.

<br>

## 3. Project and scope

The virtual setup needs to be as close as possible to the real setup.
We need to have realistic and testable scenarios about access control, room usage, circulation, signage, furniture, storage, plugs, toilets, and as many details as possible.

This means, we need to obey the laws of physics in the virtual world, without super powers meaning you cannot walk across walls, fly, etc.

However we do not need to create the 3D model of the structure.

We are only meant to verify its content and add furniture.

<br>

## 4. Risks and assumptions

One of the major risk for this project is the initial 3D model of the building. We cannot assume the provided model to be perfect and it may not be compatible with our softwares.


Since this model is a major corner-stone, any problem with the original file may cause either a lot of delay in the final delivery or reduce the quality of the other features.

Compatibility between all headsets is not guaranteed.

<br>

## 5. Requirements specs

The user should be able to move in a 3D space inside the school and interact with the different components.
Those interactions should be possible using a VR headset and controllers.

Different components with their own way of interaction should be available.
Those interactions should be realistic and realistic enough to be used in real life, more infos in the technical specifications.

<br>

## 6. Solution overview

First of all, the user will be placed in a persona selected from this list:
- Student
  - Can unlock project rooms and classrooms
- Staff
  - Has access to everything
- Professor
  - Can unlock project rooms and classrooms
  - Has access to the copy machine room
- Janitor
  - Can unlock every room other than the server room and stocks
- Investor
  - Does not have a card
  - Cannot unlock doors by themselves
  - Requires Franck's NPC[^11]
- Visitor
  - Does not have a card
  - Cannot unlock doors by themselves
  - Requires a staff or student NPC
- Other employee
  - Works on the second floor
  - Does not have access to any of the ground level 

Additional modifiers can be applied to a persona:
- Man / Woman
- Smoker
  - Special student
  - Needs to go outside at every break for at least 10 minutes
- Handicapped person with reduced mobility
  - Modifier combined with one of the previous roles
  - Cannot use the stairs
  - Has a special access to the elevator

Then, since we will simulate reality, we are going to implement physics features including gravity, solid walls, and time flow.

On top of that will be different items and objects that the user will interact with. Those will be:
- Furniture (+electric plugs, toilets...)
- Unlocking doors with a magnetic card or phone via bluetooth
- Lights with motion sensors and switches
- Functional whiteboards
- The elevator for the handicapped persona
- Signage on doors (+schedules) and around the school

All of this will be used to recreate different situations of the daily life at school with courses, lunch time or fire exercises.

<br>

## 7. Use cases

To simulate the school life from the best of our abilities, we will have to implement different characters. The following is a table of all possible combinations that will be implemented.

| Name    | Roles      | Gender     | Vehicle    | Meal      | Handicap      | Smoker |
| ------- | ---------- | ---------- | ---------- | --------- | ------------- | ------ |
| Brandon | Student    | Male       | Bicycle    | Take Away | —             | Smoker |
| Pierre  | Student    | Male       | By foot    | Outdoor   | —             | Smoker |
| Léo     | Student    | Male       | By foot    | Indoor    | —             | —      |
| Malo    | Student    | Male       | Scooter    | Indoor    | —             | —      |
| Cléa    | Student    | Female     | Carsharing | Indoor    | Crutches      | —      |
| Sacha   | Student    | Non binary | Scooter    | Take Away | —             | Smoker |
| Franck  | Staff      | Male       | Car        | Indoor    | —             | —      |
| Natacha | Staff      | Female     | Car        | Indoor    | —             | —      |
| Julie   | Staff      | Female     | Bicycle    | Indoor    | —             | —      |
| Eric L. | Investor   | Male       | Car        | Outdoor   | —             | —      |
| Guy     | Intervener | Male       | Carsharing | Indoor    | Rolling Chair | —      |
| Aude    | Janitor    | Female     | Car        | —         | —             | —      |
| Gus     | Visitor    | Male       | Car        | —         | —             | —      |

<br>

## 8. User flow

To accommodate the player and make the experience more realistic, there will be NPCs around the school. Their flow of actions is described in this section.

### Student

- The students NPCs will be assigned to a room:
  - Project room
  - Class room
  - English room
  - Soft skills room
- They will stay in their room and act as if studying
- At random, a student may leave the room and go to the toilets
- When break time will be called, some students will go to the toilets and the others will wander around the place

### Staff

- The staff NCP will be split between their respective rooms:
  - Reception
  - 3 offices
  - 2 meeting rooms
  - Copy machines room
- They will stay in their room and act as if working
- At random, a staff member may leave the room and go to the toilets
- Break time does not affect them

### Professor

- There will be one professor for each classroom with students in them
- They will stay in the classroom until the end of the day or lunch time
- They may differ in soft skill rooms such as having an additional teacher

<br><br>

Footnotes:
[^0]: Virtual reality (VR) is a simulated experience that can be similar to or completely different from the real world. Applications of virtual reality include entertainment, education and business. Other distinct types of VR-style technology include augmented reality and mixed reality, sometimes referred to as extended reality or XR.

[^1]: An innovative programming school based in Vierzon, France.

[^2]: The B3 is an old factory that used to house the Société Française(a company that made tractors), now this building has been restored to contain Algosup, the CNAM, a start-up incubator and a connected campus.

[^3]: A BIMx file is a document created by GRAPHISOFT ArchiCAD, an architectural CAD program. It contains a virtual architectural project that includes 3D models and 2D drawing sheets.

[^4]: FBX (Filmbox) is a proprietary file format ( .fbx ) developed by Kaydara and owned by Autodesk since 2006. It is used to provide interoperability between digital content creation applications. FBX is also part of Autodesk Gameware, a series of video game middleware.

[^5]: An MLT file is a project created by Meltytech Shotcut, an open source video editor. It contains project settings in XML format, which includes information about media imported in the project, media placed on the timeline, effects applied to the media, and video and audio properties.

[^6]: An OBJ file is a standard 3D image format that can be exported and opened by various 3D image editing programs. It contains a three-dimensional object, which includes 3D coordinates, texture maps, polygonal faces, and other object information. OBJ files may also store references to one or more .

[^7]: Oculus Quest 2 is a virtual reality headset created by Facebook Technologies. It is the successor to the company's previous headset, the Oculus Quest.
The included controllers with the Quest 2 are the third generation Oculus Touch controllers.

[^8]: Visual Studio Code is a source-code editor made by Microsoft for Windows, Linux and macOS. Features include support for debugging, syntax highlighting, intelligent code completion, snippets, code refactoring, embedded Git, and more.

[^9]: Unity is a cross-platform game engine developed by Unity Technologies. The engine support a variety of desktop, mobile, console and virtual reality platforms. It is particularly popular for iOS and Android mobile game development and used for games such as Pokémon Go. It is considered easy to use for beginner developers and is popular for indie game development.

[^10]: SolidWorks is a solid modeling computer-aided design and computer-aided engineering computer program published by Dassault Systèmes, that runs primarily on Microsoft Windows.

[^11]: Non Playable Character: A virtual avatar that you can interact with. This character will be controlled by the game itself.
