docker container rm netweb-container

docker build -t netweb-image .
docker run -d -p 5000:5000 --name netweb-container netweb-image
