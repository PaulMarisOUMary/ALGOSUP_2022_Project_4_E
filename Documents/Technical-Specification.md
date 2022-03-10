<!-- doc https://stackoverflow.blog/2020/04/06/a-practical-guide-to-writing-technical-specs/ -->
<!-- md gen https://ecotrust-canada.github.io/markdown-toc/-->

# Technical Specification

- [Technical Specification](#technical-specification)
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
      - [a. Current or Existing Solution / Design](#a-current-or-existing-solution--design)
      - [b. Suggested or Proposed Solution / Design](#b-suggested-or-proposed-solution--design)
      - [c. Test Plan](#c-test-plan)
      - [d. Monitoring and Alerting Plan](#d-monitoring-and-alerting-plan)
      - [e. Release / Roll-out and Deployment Plan](#e-release--roll-out-and-deployment-plan)
      - [f. Rollback Plan](#f-rollback-plan)
      - [g. Alternate Solutions / Designs](#g-alternate-solutions--designs)
  - [4. Further Considerations](#4-further-considerations)
      - [a. Impact on other teams](#a-impact-on-other-teams)
      - [b. Third-party services and platforms considerations](#b-third-party-services-and-platforms-considerations)
      - [c. Cost analysis](#c-cost-analysis)
      - [d. Security considerations](#d-security-considerations)
      - [e. Privacy considerations](#e-privacy-considerations)
      - [f. Regional considerations](#f-regional-considerations)
      - [g. Accessibility considerations](#g-accessibility-considerations)
      - [h. Operational considerations](#h-operational-considerations)
      - [i. Risks](#i-risks)
      - [j. Support considerations](#j-support-considerations)
  - [5. Success Evaluation](#5-success-evaluation)
      - [a. Impact](#a-impact)
      - [b. Metrics](#b-metrics)
  - [Works](#works)
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

## 1. Front matter
- Title: Virtual Reality of the Future B3
- Author(s): Clément CATON, Florent HUREAUX, Laurent BOUQUIN, Léo CHARTIER, Paul MARIS, Pierre GORIN
- Team: ALGOSUP_2022_PROJECT_4_E
- Reviewers(s): Team/Franck JEANNIN
- Created on: 04/03/2022
- Last updated: 04/03/2022

## 2. Introduction

#### a. Overview, Problem Description, Summary, or Abstract

Our project is based on Virtual Reality. We need to make sure that the  model provided from the Algosup to B3 will correspond  to the needs of the school and then to simulate a typical day at school.

We have had some issues with the 3d model, we need to refactor the 3d model of B3.

#### b. Glossary or Terminology

#### c. Context or Background

This project was made in order to find some possible issues that we can solve before making the B3 building. It's worth doing because it will allowed ALGOSUP to correct potential issues before going in which will result in a gain of time and money.

#### d. Goals or Product and Technical Requirements

#### e. Non-Goals or Out of Scope

#### f. Future Goals

#### g. Assumptions

## 3. Solutions

#### a. Current or Existing Solution / Design

Right now, we are provided with the 3D file produced by the architect of the building in the BIMx format, as well as 2D maps of each floor (PDF).

#### b. Suggested or Proposed Solution / Design 

In order to use it on Unity, we will convert the 3D map in one of the following format: FBX, MLT & OBJ.

#### c. Test Plan

x

#### d. Monitoring and Alerting Plan 

#### e. Release / Roll-out and Deployment Plan

#### f. Rollback Plan

#### g. Alternate Solutions / Designs

## 4. Further Considerations

#### a. Impact on other teams

#### b. Third-party services and platforms considerations

#### c. Cost analysis

#### d. Security considerations

#### e. Privacy considerations

#### f. Regional considerations

#### g. Accessibility considerations

#### h. Operational considerations

#### i. Risks

There are some risks to take into consideration in this project :

- Deliverable : We can be late. There are a lot to do.

- Materials : We need to take care of the material at our disposal.
Clément will be responsible for the well maintain of the occulus.

- Compatibility problem between occulus and our computer (windows/mac)

#### j. Support considerations

In the case we have no longer acess to the occulus, we could switch to a 3D navigation without using VR to assure the continuity of the project.

## 5. Success Evaluation

#### a. Impact

#### b. Metrics

## 6. Works

#### a. Work estimates and timelines

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

#### b. Prioritization

In the first two weeks, we prioritized writing the functional specification and the technical specification to make sure everything was understood and to simplify the work.
Next, we will make all the physics of the 3D world and implement all the object we need. We also need to make the NPC afterward and multiple persona that the users can incarnate.
Then in the two last week we are going to debug, finish what is missing and prepare for the oral exam.

Finally, if and only if we have some time remaining, we will also implement different menus to allow the user to control its environnement. Those would modify the personae, schedule organization and the furniture placement.

#### c. Milestones

- Functional specification
- Technical specification
- Physics, animations, objects implementation
- First persona
- NPC 
- Oral exam

#### d. Future Work

If not already done, implementation of the control menus should be done later.

More animations and interactions may be added. Those include the second floor, off limit areas, etc...

## 7. Deliberation

#### a. Discussion

#### b. Open Questions

## 8. End Matter

#### a. Related Work

#### b. References

#### c. Acknowledgement