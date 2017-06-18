ACME
======
Banking System
<p align="center">
    <img width = "100" src="https://avatars0.githubusercontent.com/u/53395?v=3&s=400" alt=""/>
    <img width = "100" src="http://devstickers.com/assets/img/pro/2p4i.png" alt=""/>
</p>

## Notes
As extra, I decided to make this application deployable to Kubernetes as a "microservice". This will create a Docker image and push the image to a Google Container Registory. Once pushed, a pre-existing project with Kubernetes clusters has been made to run the Docker image. Currently, there is only once instance of the application running on Kubernetes but can be scaled to as many as needed. 

<b> There is a forever loop in the main application due to the nature of Kubernetes needing a "forever" process for their running containers, otherwise it goes into an infinite restart loop. This can be removed. </b>

To setup this environment, install Docker, The Google Cloud Platform SDK and Node.js and run the setup.sh script and send me your email so that I can add you onto the project. Or alternatively you could watch the supplied video with the deploymenty below.
