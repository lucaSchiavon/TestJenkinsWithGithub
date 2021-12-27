pipeline {
    agent any
	
	environment {
		WORKSP="${workspace}"
		PROJNAME="${env.PROJECT_NAME}"
	}

    stages {
	stage('read variables'){
		steps{
			echo WORKSP
			echo PROJNAME
		}
	}
        stage('Build') {
            steps {
			
                echo 'Building..'
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}