pipeline {
    agent {
        docker { 
            image 'microsoft/dotnet:sdk'
            label 'ubuntu_1804_agent'
        }
    }
    stages {
        stage('Test') {
            steps {
                sh 'cd ./tests/'
                sh 'dotnet test'
            }
        }
        stage('Build') {
            steps {
                sh 'cd ../class-library/'
                sh 'dotnet build'
            }
        }
    }
}
