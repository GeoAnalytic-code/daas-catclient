<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Thanks again! Now go create something AMAZING! :D
***
-->

<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![MIT License][license-shield]][license-url]

<br />
<p align="center">

  <h3 align="center">DaaS-CatClient</h3>

  <p align="center">
    An example C# application to display STAC information.
    <br />
    <a href="https://github.com/GeoAnalytic-code/daas-catclient"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/GeoAnalytic-code/daas-catclient/issues">Report Bug</a>
    ·
    <a href="https://github.com/GeoAnalytic-code/daas-catclient/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary><h2 style="display: inline-block">Table of Contents</h2></summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project
This code may be used to create a STAC client using C#. [STAC] (https://stacspec.org/) is a specification for transferring metadata in JSON format between a STAC server and a STAC client.  The metadata describes spatio-temporal data such as satellite imagery.  While other exapmles of STAC clients are written in JavaScript, this STAC client is written in C#.

### Built With

* [DotNetStac](https://github.com/Terradue/DotNetStac)

## Getting Started
### Installation
This client must be built using Microsoft's Visual Studio.  Clone this repository using git (or download the zip), open the StacCommand.sln with Visual Studio and build the project.

## Usage
Once you've built the StacCommand executable, you can execute staccommand.exe:
```
staccommand.exe
usage:
staccommand <stac Uri>
```

<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/GeoAnalytic-code/daas-catclient/issues) for a list of proposed features (and known issues).



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request


<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.

<!-- CONTACT -->
## Contact

Brent Fraser - [@GeoAnalyticInc](https://twitter.com/GeoAnalyticInc) - info@geoanalytic.com  [![LinkedIn][linkedin-shield]][linkedin-url]

Project Link: [https://github.com/GeoAnalytic-code/daas-catclient](https://github.com/GeoAnalytic-code/daas-catclient)

<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
A portion of this work was generously supported through the GeoConnections programme, part of Canada's Spatial Data Infrastructure. 
* [GeoConnections](https://www.nrcan.gc.ca/science-data/science-research/earth-sciences/geomatics/canadas-spatial-data-infrastructure/10783)


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/GeoAnalytic-code/daas-catclient.svg?style=plastic
[contributors-url]: https://github.com/GeoAnalytic-code/daas-catclient/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/GeoAnalytic-code/daas-catclient.svg?style=plastic
[forks-url]: https://github.com/GeoAnalytic-code/daas-catclient/network/members
[stars-shield]: https://img.shields.io/github/stars/GeoAnalytic-code/daas-catclient.svg?style=plastic
[stars-url]: https://github.com/GeoAnalytic-code/daas-catclient/stargazers
[issues-shield]: https://img.shields.io/github/issues/GeoAnalytic-code/daas-catclient.svg?style=plastic
[issues-url]: https://github.com/GeoAnalytic-code/daas-catclient/issues
[python-shield]: https://img.shields.io/pypi/pyversions/pystac?style=plastic
[license-shield]: https://img.shields.io/github/license/Geoanalytic-code/daas-catclient?style=plastic
[license-url]: https://github.com/GeoAnalytic-code/daas-catclient/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=plastic&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/david-currie-4a129920/
[workflow-shield]: https://img.shields.io/github/workflow/status/geoanalytic-code/daas-catclient/Python%20application
