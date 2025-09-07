pipeline {
    agent any

    stages {
        stage('Restore') {
            steps {
                sh 'dotnet restore ConsoleAppWithJenkinsPipeline/ConsoleAppWithJenkinsPipeline.sln'
				echo "Restored."
            }
        }

		stage('Clean') {
            steps {
                sh 'dotnet clean ConsoleAppWithJenkinsPipeline/ConsoleAppWithJenkinsPipeline.sln'
				echo "Cleaned."
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
				echo "Tested."
            }
        }
    }

    post {
        always {
            echo "Pipeline finished."
        }
    }
}
