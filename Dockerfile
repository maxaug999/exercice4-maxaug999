# building our new image from the microsft SQL 2017 image
FROM mcr.microsoft.com/mssql/server:latest

#Les crédentials du serveur MSSQL
ENV sa_password=1Secure*Password1				
ENV ACCEPT_EULA=Y

#TODO :
#1) Regarder ce que fait le fichier run.sh
#2) Développer une série d'instructions pour copier le ficher run.sh et script.sql sur dans le container (ressemble beaucoup à l'exercice helloscripts)
#   Note :  On devra faire un chmod +x sur le fichier run.sh
#3) Faire en sorte que le fichier run.sh soit exécuté (le shell est "sh")
#4) Spécifiez que /src est le dossier courant dans le container
#4) Exposer le port 1433

CMD ["sh","/script/run.sh"]

COPY run.sh /script/run.sh
#RUN chmod a+x /script/run.sh

#script local to container 
#COPY script.sql /src/script.sql

WORKDIR /src

EXPOSE 1433

#WORKDIR /app
#RUN chmod +x run.sh
#COPY run.sh ./
#COPY script.sql ./
#CMD["sh", "/app/run.sh"]
#WORKDIR /src
#EXPOSE 1433