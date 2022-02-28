
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
<br><br>

# Project 4: Virtual Reality - Group E

Functional Specification **February 2022**

Team: _Paul MARIS, Clément CATON, Laurent BOUQUIN, Florent HUREAUX, Léo CHARTIER, Pierre GORIN_

<br>

# Overview

Our project is based on the Virtual Reality[^1], we have to use it to simulate a typical day in Algosup[^2] when it will be based at B3[^3].

<br>

## 1. Stakeholders

| Who ?                | Roles           |
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

The goal of this project is to animate the 3D model of the school in VR. This means we need to create interactivity with the components around the school in order to fully experience a day in the life of a school member.

One of our goal is to furnish the building and simulate things such as doors, classes, general daily life and many other things that we have to imagine.

<br>

## 3. Project and scope

We need to have realistic and testable scenarios about access control, room usage, circulation, signage, furniture, storage, plugs, toilets, etc.
The virtual setup needs to be as close as possible to the real setup.

We need to obey the laws of physics in the virtual world, no super powers, you can’t walk across walls, fly, etc.

However we do not need to create the 3D model of the structure, given to us by the architect.

<br>

## 4. Resources

At out disposal, we are provided with a 3d file produced by the architect of the building (BIMx[^4], FBX[^5], MLT[^6] & OBJ[^7]) as well as 2D maps of each floor (PDF).

We use an Oculus Quest 2[^8] to support our simulation.

We use the following softwares:
- Visual Studio[^9]
- Unity[^10]
- Oculus
- Solidworks[^11]

For the furniture, we can freely use the models on Unity's Asset Store.

<br>

## 5. Risks and assumptions

One of the major risk for this project is the initial 3D model of the building. Even though we are provided with it by the architect who is a professional, we cannot assume it to be perfect and the model may not be compatible with our softwares.

Since this model is a major corner-stone, any problem with the original file may cause either a lot of delay in the final delivery or reduce the quality of the other features.

Compatibility between all headsets is not guaranteed.

<br>

## 6. Use cases

The reason for this project is that the school's staff want to preview the final build before the end of the constructions. This will allow them to adapt for the future such as buying new furniture.

This will also allow them for marketing purposes and promote the school more easily.

Finally, since the simulation is not limited to a single place, anyone with a VR headset will be able to virtually visit the new school.
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
- Staff [Franck Jeannin]
- Professor [Sebastien Goisbeault]
- Visitor [Éric Larchevêque]
- Handicapped person with reduced mobility (wheelchair) [Stephen Hawking]

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

[^1]: Virtual reality (VR) is a simulated experience that can be similar to or completely different from the real world. Applications of virtual reality include entertainment, education and business. Other distinct types of VR-style technology include augmented reality and mixed reality, sometimes referred to as extended reality or XR.

[^2]: An innovative programming school based in Vierzon, France.

[^3]: The B3 is an old factory that used to house the Société Française(a company that made tractors), now this building has been restored to contain Algosup, the CNAM, a start-up incubator and a connected campus.

[^4]: A BIMx file is a file created by GRAPHISOFT ArchiCAD, an architectural CAD program. It contains a virtual architectural project that includes 3D models and 2D drawing sheets. BIMx files are created in ArchiCAD when a user exports the project to the BIMx format.

[^5]: FBX (Filmbox) is a proprietary file format ( . fbx ) developed by Kaydara and owned by Autodesk since 2006. It is used to provide interoperability between digital content creation applications. FBX is also part of Autodesk Gameware, a series of video game middleware.

[^6]: An MLT file is a project created by Meltytech Shotcut, an open source video editor. It contains project settings in XML format, which includes information about media imported in the project, media placed on the timeline, effects applied to the media, and video and audio properties.

[^7]: An OBJ file is a standard 3D image format that can be exported and opened by various 3D image editing programs. It contains a three-dimensional object, which includes 3D coordinates, texture maps, polygonal faces, and other object information. OBJ files may also store references to one or more.

[^8]: Oculus Quest 2 is a virtual reality headset created by Facebook Technologies, It is the successor to the company's previous headset, the Oculus Quest.
The included controllers with the Quest 2 are the third generation Oculus Touch controllers.

[^9]: Visual Studio Code is a source-code editor made by Microsoft for Windows, Linux and macOS. Features include support for debugging, syntax highlighting, intelligent code completion, snippets, code refactoring, and embedded Git.

[^10]: Unity is a cross-platform game engine developed by Unity Technologies,The engine support a variety of desktop, mobile, console and virtual reality platforms. It is particularly popular for iOS and Android mobile game development and used for games such as Pokémon Go. It is considered easy to use for beginner developers and is popular for indie game development.

[^11]: SolidWorks is a solid modeling computer-aided design and computer-aided engineering computer program published by Dassault Systèmes, that runs primarily on Microsoft Windows.