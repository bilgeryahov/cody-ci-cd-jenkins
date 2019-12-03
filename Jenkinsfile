pipeline {
    agent {
        docker { 
            image 'microsoft/dotnet:sdk'
            label 'ubuntu_1804_agent'
        }
    }
    environment {
        HOME = '/tmp'
    }
    stages {
        stage('Test') {
            steps {
                sh 'cd ./tests/ && dotnet test'
            }
        }
        stage('Build') {
            steps {
                sh 'cd ../class-library/ && dotnet build'
            }
        }
    }
}
