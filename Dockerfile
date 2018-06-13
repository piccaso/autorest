FROM ubuntu:xenial 

LABEL maintainer="fearthecowboy" 

# Required for install
RUN apt-get update && apt-get install -y curl libunwind8 libicu55

# NodeJS
RUN curl -sL https://deb.nodesource.com/setup_7.x | bash - && \
	apt-get update && apt-get install -y nodejs locales && \
	npm install npm@latest -g && locale-gen en_US.UTF-8

# Autorest
RUN npm install -g autorest@2.0.4143
RUN autorest --reset --allow-no-input --csharp --go --nodejs --typescript --azure-validator

# Set the locale to UTF-8
ENV LANG en_US.UTF-8  
ENV LANGUAGE en_US:en  
ENV LC_ALL en_US.UTF-8  

# warmup for csharp
ADD http://petstore.swagger.io/v2/swagger.json ./petstore.swagger.json
RUN autorest -i petstore.swagger.json -o petstore-autorest-client -n PetstoreClient

ENTRYPOINT ["autorest"]
