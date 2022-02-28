# Project 4: Virtual Reality - Group E

<details>
<summary>Table of content</summary>

- [Project 4: Virtual Reality - Group E](#project-4-virtual-reality---group-e)
- [Overview](#overview)
  - [1. Stakeholders](#1-stakeholders)
  - [2. Project target](#2-project-target)
  - [3. Project and scope](#3-project-and-scope)
  - [4. Resources](#4-resources)
  - [5. Risks and assumptions](#5-risks-and-assumptions)
  - [6. Use cases](#6-use-cases)
  - [7. Requirements specs](#7-requirements-specs)
  - [8. Solution overview](#8-solution-overview)

</details>
<br>

Functional Specification **February 2022**

Team: _Paul MARIS, Clément CATON, Laurent BOUQUIN, Florent HUREAUX, Léo CHARTIER, Pierre GORIN_

<br>

# Overview

Our project is based on Virtual Reality (VR). We have to use it to simulate a typical day at Algosup[^6] when it will be based at the B3[^7].

<br>

## 1. Stakeholders

| Person/Organization  | Role            |
| -------------------- | --------------- |
| ALGOSUP              | Customers       |
|                      | Architect       |
| Sébastien GOISBEAULT | Tech consultant |
| Paul MARIS           | Project manager |
| Clément CATON        | Tech lead       |
| Laurent BOUQUIN      | Team member     |
| Florent HUREAUX      | Team member     |
| Léo CHARTIER         | Team member     |
| Pierre GORIN         | Team member     |

<br>

## 2. Project target

The goal of this project is to give life to the 3D model of the school in VR. This means we need to create interactivity with the components around the school in order to fully experience a day in the life of a school member.

One of our goal is to furnish the building and simulate things such as doors, classes, general daily life and many other things that we have to imagine.

<br>

## 3. Project and scope

We need to have realistic and testable scenarios about access control, room usage, circulation, signage, furniture, storage, plugs, toilets, etc.
The virtual setup needs to be as close as possible to the real setup.

This, we need to obey the laws of physics in the virtual world, without super powers meaning you cannot walk across walls, fly, etc.

However we do not need to create the 3D model of the structure, given to us by the architect.

<br>

## 4. Resources

At out disposal, we are provided with the 3D file produced by the architect of the building in the BIMx[^1] format, as well as 2D maps of each floor (PDF). For practicality reasons, we will convert the 3D map in one of the following format: FBX[^8], MLT[^9] & OBJ[^10].

We will use an Oculus Quest 2[^2] to support our simulation.

We will also use the following softwares:
- Visual Studio[^3]
- Unity[^4]
- Oculus
- Solidworks[^5]

For the furniture, we can freely use the models on Unity's Asset Store or from other models libraries.

<br>

## 5. Risks and assumptions

One of the major risk for this project is the initial 3D model of the building. Even though we are provided with it by the architect who is a professional, we cannot assume it to be perfect and the model may not be compatible with our softwares.

Since this model is a major corner-stone, any problem with the original file may cause either a lot of delay in the final delivery or reduce the quality of the other features.

Compatibility between all headsets is not guaranteed.

<br>

## 6. Use cases

The reason for this project is that the school's staff want to preview the final build before the end of the constructions. This will allow them to adapt for the future such as buying new furniture.

This will also allow them for marketing purposes and promote the school more easily.

Finally, since the simulation will be only and not restricted to the Algosup building, anyone with a VR headset will be able to virtually visit the new school.
This will be useful for potential students far away from their location (even abroad).
Moreover, with the Covid pandemic, this will also make visits easier by not having physical contact and reducing the probability of infection.

<br>

## 7. Requirements specs

The user should be able to move in a 3D space inside the school and interact with the different components.
Those interactions should be possible using a VR headset and controllers.

Different components with their own way of interaction should be available.
Those interactions should be realistic and realistic enough to be used in real life, more infos in the technical specifications.

<br>

## 8. Solution overview

First of all, the user will be placed in a personae selected from this list:
- Student [Léo Chartier]
  - Can unlock project rooms and classrooms
- Staff [Franck Jeannin]
  - Has access to everything
- Professor [Sebastien Goisbeault]
  - Can unlock project rooms and classrooms
  - Has access to the copy machine room
- Investor [Éric Larchevêque]
  - Does not have a card
  - Cannot unlock doors by themselves
  - Requires Francks's NPC[^11]
- Visitor [Bénédicte de Choulot]
  - Does not have a card
  - Cannot unlock doors by themselves
  - Requires a staff or student NPC
- Handicapped person with reduced mobility (wheelchair) [Stephen Hawking]
  - Modifier combined with one of the previous roles
  - Cannot use the stairs
  - Has a special access to the elevator

Then, since we will simulate reality, we are going to implement physics features including gravity, solid walls, and a day/night cycle.

On top of that will be different items and objects that the user will interact with. Those will be:
- Furniture (+electric plugs, toilets...)
- Unlocking doors with a magnetic card
- Lights with motion sensors and switches
- Functional whiteboards
- The elevator for the handicapped personae
- Signage on doors (+schedules) and around the school

All of this will be used to recreate different situations of the daily life at school with courses, lunch time or fire exercises.

<br><br>

Footnotes:

[^1]: A BIMx file is a document created by GRAPHISOFT ArchiCAD, an architectural CAD program. It contains a virtual architectural project that includes 3D models and 2D drawing sheets.

[^2]: Oculus Quest 2 is a virtual reality headset created by Facebook Technologies. It is the successor to the company's previous headset, the Oculus Quest.
The included controllers with the Quest 2 are the third generation Oculus Touch controllers.

[^3]: Visual Studio Code is a source-code editor made by Microsoft for Windows, Linux and macOS. Features include support for debugging, syntax highlighting, intelligent code completion, snippets, code refactoring, embedded Git, and more.

[^4]: Unity is a cross-platform game engine developed by Unity Technologies. The engine support a variety of desktop, mobile, console and virtual reality platforms. It is particularly popular for iOS and Android mobile game development and used for games such as Pokémon Go. It is considered easy to use for beginner developers and is popular for indie game development.

[^5]: SolidWorks is a solid modeling computer-aided design and computer-aided engineering computer program published by Dassault Systèmes, that runs primarily on Microsoft Windows.

[^6]: An innovative programming school based in Vierzon, France.

[^7]: The B3 is an old factory that used to house the Société Française(a company that made tractors), now this building has been restored to contain Algosup, the CNAM, a start-up incubator and a connected campus.

[^8]: FBX (Filmbox) is a proprietary file format ( .fbx ) developed by Kaydara and owned by Autodesk since 2006. It is used to provide interoperability between digital content creation applications. FBX is also part of Autodesk Gameware, a series of video game middleware.

[^9]: An MLT file is a project created by Meltytech Shotcut, an open source video editor. It contains project settings in XML format, which includes information about media imported in the project, media placed on the timeline, effects applied to the media, and video and audio properties.

[^10]: An OBJ file is a standard 3D image format that can be exported and opened by various 3D image editing programs. It contains a three-dimensional object, which includes 3D coordinates, texture maps, polygonal faces, and other object information. OBJ files may also store references to one or more .

[^11]: Non Playable Character: A virtual avatar that you can interact with. This character will be controlled by the game itself.