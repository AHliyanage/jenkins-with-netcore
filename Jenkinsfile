pipeline {
    agent any

    stages {
        stage('Restore') {
            steps {
                sh 'dotnet restore ConsoleAppWithJenkinsPipeline/ConsoleAppWithJenkinsPipeline.sln'
		echo "Restored."
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build ConsoleAppWithJenkinsPipeline/ConsoleAppWithJenkinsPipeline.sln --configuration Release'
		echo "Built."
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test ConsoleAppWithJenkinsPipeline/ConsoleAppWithJenkinsPipeline.sln --no-build --configuration Release'
		cho "Tested."
            }
        }
    }

    post {
        always {
            echo "Pipeline finished."
        }
    }
}
