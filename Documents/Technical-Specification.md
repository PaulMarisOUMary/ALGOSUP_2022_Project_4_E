<!-- doc https://stackoverflow.blog/2020/04/06/a-practical-guide-to-writing-technical-specs/ -->
<!-- md gen https://ecotrust-canada.github.io/markdown-toc/-->

# Technical Specification

- [1. Front matter](#1-front-matter)
- [2. Introduction](#2-introduction)
  - [a. Overview, Problem Description, Summary, or Abstract](#a-overview-problem-description-summary-or-abstract)
  - [b. Glossary or Terminology](#b-glossary-or-terminology)
  - [c. Context or Background](#c-context-or-background)
  - [d. Goals or Product and Technical Requirements](#d-goals-or-product-and-technical-requirements)
  - [e. Non-Goals or Out of Scope](#e-non-goals-or-out-of-scope)
  - [f. Future Goals](#f-future-goals)
  - [g. Assumptions](#g-assumptions)
- [3. Solutions](#3-solutions)
  - [a. Current Design](#a-current-design)
  - [b. Suggested or Proposed Solution / Design](#b-suggested-or-proposed-solution--design)
  - [c. Test Plan](#c-test-plan)
  - [d. Monitoring and Alerting Plan](#d-monitoring-and-alerting-plan)
  - [e. Release / Roll-out and Deployment Plan](#e-release--roll-out-and-deployment-plan)
- [4. Further Considerations](#4-further-considerations)
  - [a. Third-party services and platforms considerations](#a-third-party-services-and-platforms-considerations)
  - [b. Cost analysis](#b-cost-analysis)
  - [c. Security considerations](#c-security-considerations)
  - [d. Privacy considerations](#d-privacy-considerations)
  - [e. Accessibility considerations](#e-accessibility-considerations)
  - [f. Operational considerations](#f-operational-considerations)
  - [g. Risks](#g-risks)
  - [i. Support considerations](#i-support-considerations)
- [5. Success Evaluation](#5-success-evaluation)
  - [a. Impact](#a-impact)
  - [b. Metrics](#b-metrics)
- [6. Works](#6-works)
  - [a. Work estimates and timelines](#a-work-estimates-and-timelines)
  - [b. Prioritization](#b-prioritization)
  - [c. Milestones](#c-milestones)
  - [d. Future Work](#d-future-work)
- [7. Deliberation](#7-deliberation)
  - [a. Discussion](#a-discussion)
  - [b. Open Questions](#b-open-questions)
- [8. End Matter](#8-end-matter)
  - [a. Related Work](#a-related-work)
  - [b. References](#b-references)
  - [c. Acknowledgement](#c-acknowledgement)

<br><br>



## 1. Front matter
- Title: Virtual Reality of the Future B3
- Authors: Clément CATON, Florent HUREAUX, Laurent BOUQUIN, Léo CHARTIER, Paul MARIS, Pierre GORIN
- Team: ALGOSUP_2022_PROJECT_4_E
- Reviewers: Team / Franck JEANNIN
- Created on: 04/03/2022
- Last updated: 10/03/2022

<br><br>



## 2. Introduction

### a. Overview, Problem Description, Summary, or Abstract

Our project is based on Virtual Reality. We need to make sure that the  model provided from the Algosup to B3 will correspond  to the needs of the school and then to simulate a typical day at school.

We have had some issues with the 3d model, we need to refactor the 3d model of B3.

<br>

### b. Glossary or Terminology

<!-- do this part at the end to know all the technical word that used in this document -->

<br>

### c. Context or Background

This project was made in order to find some possible issues that we can solve before making the B3 building. It's worth doing because it will allowed ALGOSUP to correct potential issues before going in which will result in a gain of time and money.

<br>

### d. Goals or Product and Technical Requirements

Our project will be used to visit our future premises with a total immersion, it is also used to verify if there are eventual modifications to take into account and the simulation could also be used so that the future students can visit the premises before the delivery of the building site.

<br>

### e. Non-Goals or Out of Scope

The goal of this project is to make a simulation of a typical day and events that can happen within the building, we should not make a video game, we should not make a generality and have a diversity of people present in the school, we should not worry only about people from ALGOSUP but also people from the CNAM, the start-up incubator and the connected campus.

<br>

### f. Future Goals

<br>

### g. Assumptions

<br><br>



## 3. Solutions

### a. Current Design

There are no current design. Everything will be made from scratch.

<br>

### b. Suggested or Proposed Solution / Design 

We will rely on the 3D file of the building produced by the architect in the BIMx format, as well as 2D maps of each floor (PDF).
Since we will be using Unity, the 3D model will have to be converted in the FBX format.
This will allow us to work on the project while still having every component separated from on another.

<!-- Pseudo code & flowcharts ? -->

<br>

### c. Test Plan

x <!-- What ? Does it mean we don't have any or something else ? Don't just put an X -->

<br>

### d. Monitoring and Alerting Plan 

<!-- No idea-->

<br>

### e. Release / Roll-out and Deployment Plan

The final product will be deployed and handed to the client for April 8.
After this date, development will stop unless extended by the client.

<br><br>

## 4. Further Considerations

<br>

### a. Third-party services and platforms considerations

<br>

### b. Cost analysis

The Oculus Quest 2 is provided by the school, so for groups the hardware had no cost, but the price of 1 VR headset is 350€.

<br>

### c. Security considerations

On the software side, this project can't really be threatened because we don't plan to integrate a client/server system for the moment, the project won't be public so only people inside the school will have access to it.
On the hardware side, this project is based on virtual reality, so for people who have never used this type of technology, there may be symptoms of cyberkinetosis.

> *cyberkinetosis: pallor, feeling of uneasiness, visual disturbances, disorientation, headache, tiredness, dizziness, nausea, vomiting, tachycardia, hypersalivation*

<br>

### d. Privacy considerations

We don't have any users data in our simulation, so the privacy isn't a probleme.  

<br>

### e. Accessibility considerations

To use our simulation we need to have a VR Headset. 

<br>

### f. Operational considerations

<br>

### g. Risks

There are some risks to take into consideration in this project :

- Deliverable : We can be late. There are a lot to do.

- Materials : We need to take care of the material at our disposal.
Clément will be responsible for the well maintain of the Oculus.

- Compatibility problem between Oculus and our computer (windows/mac)

<br>

### i. Support considerations

In the case we have no longer access to the Oculus, we could switch to a 3D navigation without using VR to assure the continuity of the project.

<br><br>



## 5. Success Evaluation

### a. Impact

<!-- impact of our project and the way to use our project -->

<br>

### b. Metrics

<!-- if simulation is at scale and problem with architect work -->

<br><br>



## 6. Works

### a. Work estimates and timelines

| Task                                                     | Resource                | Estimated Time |
| -------------------------------------------------------- | ----------------------- | -------------- |
| Write functional specification                           | Github / Stack Overflow | 2 week         |
| Write technical specification & architecture diagram     | Github / Stack Overflow | 1 week         |
| Simplify the 3D model                                    | Blender                 | 1 week         |
| Get a working environnement with non-nauseating movement | Unity / VR headset      | 1 week         |
| Add interactions with the 3D model                       | Unity                   | 1 ½ weeks      |
| Implement NPCs with animations and movement              | Unity                   | 1 ½ weeks      |
| Create menus to edit environnement and scenarios         | Unity                   | 3 weeks        |
| Prepare the presentation                                 | —                       | ½ week         |

Note: Number of team members assigned to each task still needs to be defined.

<br>

### b. Prioritization

In the first two weeks, we prioritized writing the functional specification and the technical specification to make sure everything was understood and to simplify the work.
Next, we will make all the physics of the 3D world and implement all the object we need. We also need to make the NPC afterward and multiple persona that the users can incarnate.
Then in the two last week we are going to debug, finish what is missing and prepare for the oral exam.

Finally, if and only if we have some time remaining, we will also implement different menus to allow the user to control its environnement. Those would modify the personae, schedule organization and the furniture placement.

<br>

### c. Milestones

- Functional specification
- Technical specification
- Physics, animations, objects implementation
- First persona
- NPC
- Oral exam

<br>

### d. Future Work

If not already done, implementation of the control menus should be done later.

More animations and interactions may be added. Those include the second floor, off limit areas, etc...

<br><br>



## 7. Deliberation

### a. Discussion

<br>

### b. Open Questions

<br><br>

## 8. End Matter

### a. Related Work

<br>

### b. References

<br>

### c. Acknowledgement
