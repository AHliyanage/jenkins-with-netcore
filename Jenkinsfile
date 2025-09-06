pipeline {
    agent any

    stages {
        stage('Restore') {
            steps {
                sh 'dotnet restore ConsoleAppWithJenkinsPipeline/ConsoleAppWithJenkinsPipeline.sln'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build ConsoleAppWithJenkinsPipeline/ConsoleAppWithJenkinsPipeline.sln --configuration Release'
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test ConsoleAppWithJenkinsPipeline/ConsoleAppWithJenkinsPipeline.sln --no-build --configuration Release'
            }
        }
    }

    post {
        always {
            echo "Pipeline finished."
        }
    }
}
