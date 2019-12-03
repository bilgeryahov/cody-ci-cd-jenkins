pipeline {
    agent {
        docker { image 'microsoft/dotnet:sdk' }
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
