pipeline {
    agent any

    stages {
        stage('Restore') {
            steps {
                sh 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build ConsoleAppWithJenkinsPipeline/ConsoleAppWithJenkinsPipeline.sln --configuration Release'
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test --no-build --configuration Release'
            }
        }
    }

    post {
        always {
            echo "Pipeline finished."
        }
    }
}
